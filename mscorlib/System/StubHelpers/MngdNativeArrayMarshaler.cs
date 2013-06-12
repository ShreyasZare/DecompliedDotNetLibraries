﻿namespace System.StubHelpers
{
    using System;
    using System.Runtime;
    using System.Runtime.CompilerServices;
    using System.Runtime.ConstrainedExecution;

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
    internal static class MngdNativeArrayMarshaler
    {
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ClearNative(IntPtr pMarshalState, IntPtr pNativeHome, int cElements);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ClearNativeContents(IntPtr pMarshalState, IntPtr pNativeHome, int cElements);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ConvertContentsToManaged(IntPtr pMarshalState, ref object pManagedHome, IntPtr pNativeHome);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ConvertContentsToNative(IntPtr pMarshalState, ref object pManagedHome, IntPtr pNativeHome);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ConvertSpaceToManaged(IntPtr pMarshalState, ref object pManagedHome, IntPtr pNativeHome, int cElements);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void ConvertSpaceToNative(IntPtr pMarshalState, ref object pManagedHome, IntPtr pNativeHome);
        [MethodImpl(MethodImplOptions.InternalCall), ForceTokenStabilization]
        internal static extern void CreateMarshaler(IntPtr pMarshalState, IntPtr pMT, int dwFlags);
    }
}

