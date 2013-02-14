﻿//-----------------------------------------------------------------------
// <copyright file="AddedNewEventArgs.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Object containing information about a</summary>
//-----------------------------------------------------------------------
using System;
using System.Net;
using System.Windows;

namespace Csla.Core
{
  /// <summary>
  /// Object containing information about a
  /// newly added object.
  /// </summary>
  /// <typeparam name="T">
  /// Type of the object that was added.
  /// </typeparam>
  public class AddedNewEventArgs<T> : EventArgs
  {
    private T _newObject;

    /// <summary>
    /// Gets a reference to the newly added
    /// object.
    /// </summary>
    public T NewObject
    {
      get { return _newObject; }
      protected set { _newObject = value; }
    }

    /// <summary>
    /// Creates a new instance of the object.
    /// </summary>
    public AddedNewEventArgs() { }

    /// <summary>
    /// Creates a new instance of the object.
    /// </summary>
    /// <param name="newObject">
    /// The newly added object.
    /// </param>
    public AddedNewEventArgs(T newObject)
    {
      NewObject = newObject;
    }
  }
}