using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace EventToObservableReflection
{
	public static class SeparatorEventToObservableExtensions
	{
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseDoubleClickObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseDoubleClick += h, h => This.PreviewMouseDoubleClick -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseDoubleClickObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseDoubleClick += h, h => This.MouseDoubleClick -= h);
		}
		public static IObservable<EventPattern<DataTransferEventArgs>> TargetUpdatedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<DataTransferEventArgs>, DataTransferEventArgs>(h => This.TargetUpdated += h, h => This.TargetUpdated -= h);
		}
		public static IObservable<EventPattern<DataTransferEventArgs>> SourceUpdatedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<DataTransferEventArgs>, DataTransferEventArgs>(h => This.SourceUpdated += h, h => This.SourceUpdated -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> DataContextChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.DataContextChanged += h, h => This.DataContextChanged -= h);
		}
		public static IObservable<EventPattern<RequestBringIntoViewEventArgs>> RequestBringIntoViewObserver(this Separator This)
		{
			return Observable.FromEventPattern<RequestBringIntoViewEventHandler, RequestBringIntoViewEventArgs>(h => This.RequestBringIntoView += h, h => This.RequestBringIntoView -= h);
		}
		public static IObservable<EventPattern<SizeChangedEventArgs>> SizeChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<SizeChangedEventHandler, SizeChangedEventArgs>(h => This.SizeChanged += h, h => This.SizeChanged -= h);
		}
		public static IObservable<EventPattern<EventArgs>> InitializedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler, EventArgs>(h => This.Initialized += h, h => This.Initialized -= h);
		}
		public static IObservable<EventPattern<RoutedEventArgs>> LoadedObserver(this Separator This)
		{
			return Observable.FromEventPattern<RoutedEventHandler, RoutedEventArgs>(h => This.Loaded += h, h => This.Loaded -= h);
		}
		public static IObservable<EventPattern<RoutedEventArgs>> UnloadedObserver(this Separator This)
		{
			return Observable.FromEventPattern<RoutedEventHandler, RoutedEventArgs>(h => This.Unloaded += h, h => This.Unloaded -= h);
		}
		public static IObservable<EventPattern<ToolTipEventArgs>> ToolTipOpeningObserver(this Separator This)
		{
			return Observable.FromEventPattern<ToolTipEventHandler, ToolTipEventArgs>(h => This.ToolTipOpening += h, h => This.ToolTipOpening -= h);
		}
		public static IObservable<EventPattern<ToolTipEventArgs>> ToolTipClosingObserver(this Separator This)
		{
			return Observable.FromEventPattern<ToolTipEventHandler, ToolTipEventArgs>(h => This.ToolTipClosing += h, h => This.ToolTipClosing -= h);
		}
		public static IObservable<EventPattern<ContextMenuEventArgs>> ContextMenuOpeningObserver(this Separator This)
		{
			return Observable.FromEventPattern<ContextMenuEventHandler, ContextMenuEventArgs>(h => This.ContextMenuOpening += h, h => This.ContextMenuOpening -= h);
		}
		public static IObservable<EventPattern<ContextMenuEventArgs>> ContextMenuClosingObserver(this Separator This)
		{
			return Observable.FromEventPattern<ContextMenuEventHandler, ContextMenuEventArgs>(h => This.ContextMenuClosing += h, h => This.ContextMenuClosing -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseDown += h, h => This.PreviewMouseDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseDown += h, h => This.MouseDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseUp += h, h => This.PreviewMouseUp -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseUp += h, h => This.MouseUp -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseLeftButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseLeftButtonDown += h, h => This.PreviewMouseLeftButtonDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseLeftButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseLeftButtonDown += h, h => This.MouseLeftButtonDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseLeftButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseLeftButtonUp += h, h => This.PreviewMouseLeftButtonUp -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseLeftButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseLeftButtonUp += h, h => This.MouseLeftButtonUp -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseRightButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseRightButtonDown += h, h => This.PreviewMouseRightButtonDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseRightButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseRightButtonDown += h, h => This.MouseRightButtonDown -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> PreviewMouseRightButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.PreviewMouseRightButtonUp += h, h => This.PreviewMouseRightButtonUp -= h);
		}
		public static IObservable<EventPattern<MouseButtonEventArgs>> MouseRightButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(h => This.MouseRightButtonUp += h, h => This.MouseRightButtonUp -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> PreviewMouseMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.PreviewMouseMove += h, h => This.PreviewMouseMove -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.MouseMove += h, h => This.MouseMove -= h);
		}
		public static IObservable<EventPattern<MouseWheelEventArgs>> PreviewMouseWheelObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseWheelEventHandler, MouseWheelEventArgs>(h => This.PreviewMouseWheel += h, h => This.PreviewMouseWheel -= h);
		}
		public static IObservable<EventPattern<MouseWheelEventArgs>> MouseWheelObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseWheelEventHandler, MouseWheelEventArgs>(h => This.MouseWheel += h, h => This.MouseWheel -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> MouseEnterObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.MouseEnter += h, h => This.MouseEnter -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> MouseLeaveObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.MouseLeave += h, h => This.MouseLeave -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> GotMouseCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.GotMouseCapture += h, h => This.GotMouseCapture -= h);
		}
		public static IObservable<EventPattern<MouseEventArgs>> LostMouseCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(h => This.LostMouseCapture += h, h => This.LostMouseCapture -= h);
		}
		public static IObservable<EventPattern<QueryCursorEventArgs>> QueryCursorObserver(this Separator This)
		{
			return Observable.FromEventPattern<QueryCursorEventHandler, QueryCursorEventArgs>(h => This.QueryCursor += h, h => This.QueryCursor -= h);
		}
		public static IObservable<EventPattern<StylusDownEventArgs>> PreviewStylusDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusDownEventHandler, StylusDownEventArgs>(h => This.PreviewStylusDown += h, h => This.PreviewStylusDown -= h);
		}
		public static IObservable<EventPattern<StylusDownEventArgs>> StylusDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusDownEventHandler, StylusDownEventArgs>(h => This.StylusDown += h, h => This.StylusDown -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> PreviewStylusUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.PreviewStylusUp += h, h => This.PreviewStylusUp -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusUp += h, h => This.StylusUp -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> PreviewStylusMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.PreviewStylusMove += h, h => This.PreviewStylusMove -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusMove += h, h => This.StylusMove -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> PreviewStylusInAirMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.PreviewStylusInAirMove += h, h => This.PreviewStylusInAirMove -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusInAirMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusInAirMove += h, h => This.StylusInAirMove -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusEnterObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusEnter += h, h => This.StylusEnter -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusLeaveObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusLeave += h, h => This.StylusLeave -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> PreviewStylusInRangeObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.PreviewStylusInRange += h, h => This.PreviewStylusInRange -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusInRangeObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusInRange += h, h => This.StylusInRange -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> PreviewStylusOutOfRangeObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.PreviewStylusOutOfRange += h, h => This.PreviewStylusOutOfRange -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> StylusOutOfRangeObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.StylusOutOfRange += h, h => This.StylusOutOfRange -= h);
		}
		public static IObservable<EventPattern<StylusSystemGestureEventArgs>> PreviewStylusSystemGestureObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusSystemGestureEventHandler, StylusSystemGestureEventArgs>(h => This.PreviewStylusSystemGesture += h, h => This.PreviewStylusSystemGesture -= h);
		}
		public static IObservable<EventPattern<StylusSystemGestureEventArgs>> StylusSystemGestureObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusSystemGestureEventHandler, StylusSystemGestureEventArgs>(h => This.StylusSystemGesture += h, h => This.StylusSystemGesture -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> GotStylusCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.GotStylusCapture += h, h => This.GotStylusCapture -= h);
		}
		public static IObservable<EventPattern<StylusEventArgs>> LostStylusCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusEventHandler, StylusEventArgs>(h => This.LostStylusCapture += h, h => This.LostStylusCapture -= h);
		}
		public static IObservable<EventPattern<StylusButtonEventArgs>> StylusButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusButtonEventHandler, StylusButtonEventArgs>(h => This.StylusButtonDown += h, h => This.StylusButtonDown -= h);
		}
		public static IObservable<EventPattern<StylusButtonEventArgs>> StylusButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusButtonEventHandler, StylusButtonEventArgs>(h => This.StylusButtonUp += h, h => This.StylusButtonUp -= h);
		}
		public static IObservable<EventPattern<StylusButtonEventArgs>> PreviewStylusButtonDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusButtonEventHandler, StylusButtonEventArgs>(h => This.PreviewStylusButtonDown += h, h => This.PreviewStylusButtonDown -= h);
		}
		public static IObservable<EventPattern<StylusButtonEventArgs>> PreviewStylusButtonUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<StylusButtonEventHandler, StylusButtonEventArgs>(h => This.PreviewStylusButtonUp += h, h => This.PreviewStylusButtonUp -= h);
		}
		public static IObservable<EventPattern<KeyEventArgs>> PreviewKeyDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => This.PreviewKeyDown += h, h => This.PreviewKeyDown -= h);
		}
		public static IObservable<EventPattern<KeyEventArgs>> KeyDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => This.KeyDown += h, h => This.KeyDown -= h);
		}
		public static IObservable<EventPattern<KeyEventArgs>> PreviewKeyUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => This.PreviewKeyUp += h, h => This.PreviewKeyUp -= h);
		}
		public static IObservable<EventPattern<KeyEventArgs>> KeyUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(h => This.KeyUp += h, h => This.KeyUp -= h);
		}
		public static IObservable<EventPattern<KeyboardFocusChangedEventArgs>> PreviewGotKeyboardFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyboardFocusChangedEventHandler, KeyboardFocusChangedEventArgs>(h => This.PreviewGotKeyboardFocus += h, h => This.PreviewGotKeyboardFocus -= h);
		}
		public static IObservable<EventPattern<KeyboardFocusChangedEventArgs>> GotKeyboardFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyboardFocusChangedEventHandler, KeyboardFocusChangedEventArgs>(h => This.GotKeyboardFocus += h, h => This.GotKeyboardFocus -= h);
		}
		public static IObservable<EventPattern<KeyboardFocusChangedEventArgs>> PreviewLostKeyboardFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyboardFocusChangedEventHandler, KeyboardFocusChangedEventArgs>(h => This.PreviewLostKeyboardFocus += h, h => This.PreviewLostKeyboardFocus -= h);
		}
		public static IObservable<EventPattern<KeyboardFocusChangedEventArgs>> LostKeyboardFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<KeyboardFocusChangedEventHandler, KeyboardFocusChangedEventArgs>(h => This.LostKeyboardFocus += h, h => This.LostKeyboardFocus -= h);
		}
		public static IObservable<EventPattern<TextCompositionEventArgs>> PreviewTextInputObserver(this Separator This)
		{
			return Observable.FromEventPattern<TextCompositionEventHandler, TextCompositionEventArgs>(h => This.PreviewTextInput += h, h => This.PreviewTextInput -= h);
		}
		public static IObservable<EventPattern<TextCompositionEventArgs>> TextInputObserver(this Separator This)
		{
			return Observable.FromEventPattern<TextCompositionEventHandler, TextCompositionEventArgs>(h => This.TextInput += h, h => This.TextInput -= h);
		}
		public static IObservable<EventPattern<QueryContinueDragEventArgs>> PreviewQueryContinueDragObserver(this Separator This)
		{
			return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(h => This.PreviewQueryContinueDrag += h, h => This.PreviewQueryContinueDrag -= h);
		}
		public static IObservable<EventPattern<QueryContinueDragEventArgs>> QueryContinueDragObserver(this Separator This)
		{
			return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(h => This.QueryContinueDrag += h, h => This.QueryContinueDrag -= h);
		}
		public static IObservable<EventPattern<GiveFeedbackEventArgs>> PreviewGiveFeedbackObserver(this Separator This)
		{
			return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(h => This.PreviewGiveFeedback += h, h => This.PreviewGiveFeedback -= h);
		}
		public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObserver(this Separator This)
		{
			return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(h => This.GiveFeedback += h, h => This.GiveFeedback -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> PreviewDragEnterObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.PreviewDragEnter += h, h => This.PreviewDragEnter -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> DragEnterObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.DragEnter += h, h => This.DragEnter -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> PreviewDragOverObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.PreviewDragOver += h, h => This.PreviewDragOver -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> DragOverObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.DragOver += h, h => This.DragOver -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> PreviewDragLeaveObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.PreviewDragLeave += h, h => This.PreviewDragLeave -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> DragLeaveObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.DragLeave += h, h => This.DragLeave -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> PreviewDropObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.PreviewDrop += h, h => This.PreviewDrop -= h);
		}
		public static IObservable<EventPattern<DragEventArgs>> DropObserver(this Separator This)
		{
			return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(h => This.Drop += h, h => This.Drop -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> PreviewTouchDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.PreviewTouchDown += h, h => This.PreviewTouchDown -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> TouchDownObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.TouchDown += h, h => This.TouchDown -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> PreviewTouchMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.PreviewTouchMove += h, h => This.PreviewTouchMove -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> TouchMoveObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.TouchMove += h, h => This.TouchMove -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> PreviewTouchUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.PreviewTouchUp += h, h => This.PreviewTouchUp -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> TouchUpObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.TouchUp += h, h => This.TouchUp -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> GotTouchCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.GotTouchCapture += h, h => This.GotTouchCapture -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> LostTouchCaptureObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.LostTouchCapture += h, h => This.LostTouchCapture -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> TouchEnterObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.TouchEnter += h, h => This.TouchEnter -= h);
		}
		public static IObservable<EventPattern<TouchEventArgs>> TouchLeaveObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<TouchEventArgs>, TouchEventArgs>(h => This.TouchLeave += h, h => This.TouchLeave -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsMouseDirectlyOverChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsMouseDirectlyOverChanged += h, h => This.IsMouseDirectlyOverChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsKeyboardFocusWithinChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsKeyboardFocusWithinChanged += h, h => This.IsKeyboardFocusWithinChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsMouseCapturedChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsMouseCapturedChanged += h, h => This.IsMouseCapturedChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsMouseCaptureWithinChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsMouseCaptureWithinChanged += h, h => This.IsMouseCaptureWithinChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsStylusDirectlyOverChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsStylusDirectlyOverChanged += h, h => This.IsStylusDirectlyOverChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsStylusCapturedChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsStylusCapturedChanged += h, h => This.IsStylusCapturedChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsStylusCaptureWithinChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsStylusCaptureWithinChanged += h, h => This.IsStylusCaptureWithinChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsKeyboardFocusedChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsKeyboardFocusedChanged += h, h => This.IsKeyboardFocusedChanged -= h);
		}
		public static IObservable<EventPattern<EventArgs>> LayoutUpdatedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler, EventArgs>(h => This.LayoutUpdated += h, h => This.LayoutUpdated -= h);
		}
		public static IObservable<EventPattern<RoutedEventArgs>> GotFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<RoutedEventHandler, RoutedEventArgs>(h => This.GotFocus += h, h => This.GotFocus -= h);
		}
		public static IObservable<EventPattern<RoutedEventArgs>> LostFocusObserver(this Separator This)
		{
			return Observable.FromEventPattern<RoutedEventHandler, RoutedEventArgs>(h => This.LostFocus += h, h => This.LostFocus -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsEnabledChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsEnabledChanged += h, h => This.IsEnabledChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsHitTestVisibleChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsHitTestVisibleChanged += h, h => This.IsHitTestVisibleChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> IsVisibleChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.IsVisibleChanged += h, h => This.IsVisibleChanged -= h);
		}
		public static IObservable<EventPattern<DependencyPropertyChangedEventArgs>> FocusableChangedObserver(this Separator This)
		{
			return Observable.FromEventPattern<DependencyPropertyChangedEventHandler, DependencyPropertyChangedEventArgs>(h => This.FocusableChanged += h, h => This.FocusableChanged -= h);
		}
		public static IObservable<EventPattern<ManipulationStartingEventArgs>> ManipulationStartingObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationStartingEventArgs>, ManipulationStartingEventArgs>(h => This.ManipulationStarting += h, h => This.ManipulationStarting -= h);
		}
		public static IObservable<EventPattern<ManipulationStartedEventArgs>> ManipulationStartedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationStartedEventArgs>, ManipulationStartedEventArgs>(h => This.ManipulationStarted += h, h => This.ManipulationStarted -= h);
		}
		public static IObservable<EventPattern<ManipulationDeltaEventArgs>> ManipulationDeltaObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationDeltaEventArgs>, ManipulationDeltaEventArgs>(h => This.ManipulationDelta += h, h => This.ManipulationDelta -= h);
		}
		public static IObservable<EventPattern<ManipulationInertiaStartingEventArgs>> ManipulationInertiaStartingObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationInertiaStartingEventArgs>, ManipulationInertiaStartingEventArgs>(h => This.ManipulationInertiaStarting += h, h => This.ManipulationInertiaStarting -= h);
		}
		public static IObservable<EventPattern<ManipulationBoundaryFeedbackEventArgs>> ManipulationBoundaryFeedbackObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationBoundaryFeedbackEventArgs>, ManipulationBoundaryFeedbackEventArgs>(h => This.ManipulationBoundaryFeedback += h, h => This.ManipulationBoundaryFeedback -= h);
		}
		public static IObservable<EventPattern<ManipulationCompletedEventArgs>> ManipulationCompletedObserver(this Separator This)
		{
			return Observable.FromEventPattern<EventHandler<ManipulationCompletedEventArgs>, ManipulationCompletedEventArgs>(h => This.ManipulationCompleted += h, h => This.ManipulationCompleted -= h);
		}
	}
}

