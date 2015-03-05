﻿using WidgetShowcase;
using System;

// Interface to define the expected events provided by a widget with binary interactions (ex. a button).
public interface WidgetBinaryEventHandler<T>  {
  // Fires when interaction with the widget starts.
  event EventHandler<WidgetEventArg<T>> StartHandler;

  //Fires when interaction with the widget ends.
  event EventHandler<WidgetEventArg<T>> EndHandler;
}

// Interface to define the expected events provided by a widget with analog, or continuous, interactions (ex. a slider).
public interface WidgetAnalogEventHandler<T> : WidgetBinaryEventHandler<T> {
  //Fires while the widget is being interacted with.
  event EventHandler<WidgetEventArg<T>> ChangeHandler;
}