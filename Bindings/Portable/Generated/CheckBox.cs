// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// CheckBox.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Gui
{
	/// <summary>
	/// %UI element that can be toggled between unchecked and checked state.
	/// </summary>
	public unsafe partial class CheckBox : BorderImage
	{
		public CheckBox (IntPtr handle) : base (handle)
		{
		}

		protected CheckBox (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CheckBox_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (CheckBox_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CheckBox_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (CheckBox_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CheckBox_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(CheckBox));
			return new StringHash (CheckBox_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CheckBox_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(CheckBox));
			return Marshal.PtrToStringAnsi (CheckBox_GetTypeNameStatic ());
		}

		public CheckBox () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CheckBox_CheckBox (IntPtr context);

		public CheckBox (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(CheckBox));
			handle = CheckBox_CheckBox ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(CheckBox));
			CheckBox_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_OnClickBegin (IntPtr handle, ref Urho.IntVector2 position, ref Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, IntPtr cursor);

		/// <summary>
		/// React to mouse click begin.
		/// </summary>
		public override void OnClickBegin (Urho.IntVector2 position, Urho.IntVector2 screenPosition, int button, int buttons, int qualifiers, Cursor cursor)
		{
			Runtime.ValidateRefCounted (this);
			CheckBox_OnClickBegin (handle, ref position, ref screenPosition, button, buttons, qualifiers, (object)cursor == null ? IntPtr.Zero : cursor.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_OnKey (IntPtr handle, int key, int buttons, int qualifiers);

		/// <summary>
		/// React to a key press.
		/// </summary>
		public override void OnKey (int key, int buttons, int qualifiers)
		{
			Runtime.ValidateRefCounted (this);
			CheckBox_OnKey (handle, key, buttons, qualifiers);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_SetChecked (IntPtr handle, bool enable);

		/// <summary>
		/// Set checked state.
		/// </summary>
		private void SetChecked (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			CheckBox_SetChecked (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_SetCheckedOffset (IntPtr handle, ref Urho.IntVector2 rect);

		/// <summary>
		/// Set checked image offset.
		/// </summary>
		private void SetCheckedOffset (Urho.IntVector2 rect)
		{
			Runtime.ValidateRefCounted (this);
			CheckBox_SetCheckedOffset (handle, ref rect);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CheckBox_SetCheckedOffset0 (IntPtr handle, int x, int y);

		/// <summary>
		/// Set checked image offset.
		/// </summary>
		public void SetCheckedOffset (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			CheckBox_SetCheckedOffset0 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool CheckBox_IsChecked (IntPtr handle);

		/// <summary>
		/// Return whether is checked.
		/// </summary>
		private bool IsChecked ()
		{
			Runtime.ValidateRefCounted (this);
			return CheckBox_IsChecked (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 CheckBox_GetCheckedOffset (IntPtr handle);

		/// <summary>
		/// Return checked image offset.
		/// </summary>
		private Urho.IntVector2 GetCheckedOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return CheckBox_GetCheckedOffset (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return whether is checked.
		/// Or
		/// Set checked state.
		/// </summary>
		public bool Checked {
			get {
				return IsChecked ();
			}
			set {
				SetChecked (value);
			}
		}

		/// <summary>
		/// Return checked image offset.
		/// Or
		/// Set checked image offset.
		/// </summary>
		public Urho.IntVector2 CheckedOffset {
			get {
				return GetCheckedOffset ();
			}
			set {
				SetCheckedOffset (value);
			}
		}
	}
}