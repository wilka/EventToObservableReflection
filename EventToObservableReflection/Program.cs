using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EventToObservableReflection
{
    class Program
    {
        static void Main(string[] args)
        {
        var typesToDo = from t in Assembly.GetAssembly(typeof(FrameworkElement)).GetTypes()
                        where t.IsSubclassOf(typeof(FrameworkElement)) 
                                && t.IsPublic 
                                && t.GetEvents().Any()
                        select t;


            Directory.CreateDirectory("out");
            foreach (var type in typesToDo)
            {
                using (var stream = new FileStream(string.Format("out\\{0}EventToObservableExtensions.cs", type.Name), FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    WriteExtensionClass(type, new StreamWriter(stream, Encoding.UTF8));
                }
            }

            Console.WriteLine("All done.");
        }

        private static void WriteExtensionClass(Type type, TextWriter output)
        {
            var usingNamespaces = new SortedSet<string> 
            {
                type.Namespace, 
                "System.Reactive", 
                "System.Reactive.Linq"
            };

            var builder = new StringBuilder();
            builder.AppendLine("namespace EventToObservableReflection");
            builder.AppendLine("{");
            builder.AppendLine(string.Format("\tpublic static class {0}EventToObservableExtensions", type.Name));
            builder.AppendLine("\t{");

            foreach (var e in type.GetEvents())
            {
                WriteExtensionMethod(type, e, builder, usingNamespaces);
            }

            builder.AppendLine("\t}");
            builder.AppendLine("}");

            foreach (var ns in usingNamespaces)
            {
                output.WriteLine("using {0};", ns);
            }

            output.WriteLine();
            output.WriteLine(builder.ToString());
            output.Flush();
        }

        private static void WriteExtensionMethod(Type type, EventInfo eventInfo, StringBuilder builder, SortedSet<string> usingNamespaces)
        {
            var eventType = eventInfo.EventHandlerType.Name; // e.g. MouseEventHandler
            var eventName = eventInfo.Name; // e.g. MouseMove
            var eventArgs = eventInfo.EventHandlerType.GetMethod("Invoke").GetParameters()[1].ParameterType; // e.g. MouseEventArgs

            // TODO: Is event args ever generic? Might need to cope with that

            if (eventInfo.EventHandlerType.IsGenericType)
            {
                switch (eventInfo.EventHandlerType.Name)
                {
                    case "ReturnEventHandler`1":
                        eventType = string.Format("ReturnEventHandler<{0}>", eventArgs.Name);
                        break;
                    case "RoutedPropertyChangedEventHandler`1":
                        eventType = string.Format("RoutedPropertyChangedEventHandler<{0}>", eventArgs.Name);
                        break;
                    case "EventHandler`1":
                        eventType = string.Format("EventHandler<{0}>", eventArgs.Name);
                        break;
                    default:
                        throw new Exception("Can't cope with other generic types");
                }
            }

            usingNamespaces.Add(eventInfo.EventHandlerType.Namespace);
            usingNamespaces.Add(eventArgs.Namespace);

            builder.AppendLine(string.Format("\t\tpublic static IObservable<EventPattern<{0}>> {1}Observer(this {2} This)", eventArgs.Name, eventName, type.Name));
            builder.AppendLine("\t\t{");
            builder.AppendLine(string.Format("\t\t\treturn Observable.FromEventPattern<{0}, {1}>(h => This.{2} += h, h => This.{2} -= h);", eventType, eventArgs.Name, eventName));
            builder.AppendLine("\t\t}");
        }
    }
}
