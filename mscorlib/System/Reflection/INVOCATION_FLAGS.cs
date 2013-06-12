﻿namespace System.Reflection
{
    using System;

    [Flags]
    internal enum INVOCATION_FLAGS : uint
    {
        INVOCATION_FLAGS_CONSTRUCTOR_INVOKE = 0x10000000,
        INVOCATION_FLAGS_CONTAINS_STACK_POINTERS = 0x100,
        INVOCATION_FLAGS_FIELD_SPECIAL_CAST = 0x20,
        INVOCATION_FLAGS_INITIALIZED = 1,
        INVOCATION_FLAGS_IS_CTOR = 0x10,
        INVOCATION_FLAGS_IS_DELEGATE_CTOR = 0x80,
        INVOCATION_FLAGS_NEED_SECURITY = 4,
        INVOCATION_FLAGS_NO_CTOR_INVOKE = 8,
        INVOCATION_FLAGS_NO_INVOKE = 2,
        INVOCATION_FLAGS_RISKY_METHOD = 0x20,
        INVOCATION_FLAGS_SECURITY_IMPOSED = 0x40,
        INVOCATION_FLAGS_SPECIAL_FIELD = 0x10,
        INVOCATION_FLAGS_UNKNOWN = 0
    }
}

