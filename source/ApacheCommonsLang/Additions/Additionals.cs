using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using System;

namespace Org.Apache.Commons.Lang3
{
    public partial class Validate : global::Java.Lang.Object
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='validIndex' and count(parameter)=4 and parameter[1][@type='T'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
        [Register("validIndex", "(Ljava/util/Collection;ILjava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;", "")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "T extends java.util.Collection<?>" })]
        public static unsafe global::Java.Lang.Object ValidIndex(global::Java.Lang.Object collection, int index, string message, params global::Java.Lang.Object[] values)
        {
            const string __id = "validIndex.(Ljava/util/Collection;ILjava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;";
            IntPtr native_collection = JNIEnv.ToLocalJniHandle(collection);
            IntPtr native_message = JNIEnv.NewString((string)message);
            IntPtr native_values = JNIEnv.NewArray(values);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_collection);
                __args[1] = new JniArgumentValue(index);
                __args[2] = new JniArgumentValue(native_message);
                __args[3] = new JniArgumentValue(native_values);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_collection);
                JNIEnv.DeleteLocalRef(native_message);
                if (values != null)
                {
                    JNIEnv.CopyArray(native_values, values);
                    JNIEnv.DeleteLocalRef(native_values);
                }
                global::System.GC.KeepAlive(collection);
                global::System.GC.KeepAlive(values);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notEmpty' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
        [Register("notEmpty", "(Ljava/util/Collection;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;", "")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "T extends java.util.Collection<?>" })]
        public static unsafe global::Java.Lang.Object NotEmpty(global::Java.Lang.Object collection, string message, params global::Java.Lang.Object[] values)
        {
            const string __id = "notEmpty.(Ljava/util/Collection;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Collection;";
            IntPtr native_collection = JNIEnv.ToLocalJniHandle(collection);
            IntPtr native_message = JNIEnv.NewString((string)message);
            IntPtr native_values = JNIEnv.NewArray(values);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(native_collection);
                __args[1] = new JniArgumentValue(native_message);
                __args[2] = new JniArgumentValue(native_values);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_collection);
                JNIEnv.DeleteLocalRef(native_message);
                if (values != null)
                {
                    JNIEnv.CopyArray(native_values, values);
                    JNIEnv.DeleteLocalRef(native_values);
                }
                global::System.GC.KeepAlive(collection);
                global::System.GC.KeepAlive(values);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='Validate']/method[@name='notBlank' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
        [Register("notBlank", "(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;", "")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "T extends java.lang.CharSequence" })]
        public static unsafe global::Java.Lang.Object NotBlank(global::Java.Lang.Object chars, string message, params global::Java.Lang.Object[] values)
        {
            const string __id = "notBlank.(Ljava/lang/CharSequence;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/CharSequence;";
            IntPtr native_chars = JNIEnv.ToLocalJniHandle(chars);
            IntPtr native_message = JNIEnv.NewString((string)message);
            IntPtr native_values = JNIEnv.NewArray(values);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(native_chars);
                __args[1] = new JniArgumentValue(native_message);
                __args[2] = new JniArgumentValue(native_values);
                var __rm = _members.StaticMethods.InvokeObjectMethod(__id, __args);
                return (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_chars);
                JNIEnv.DeleteLocalRef(native_message);
                if (values != null)
                {
                    JNIEnv.CopyArray(native_values, values);
                    JNIEnv.DeleteLocalRef(native_values);
                }
                global::System.GC.KeepAlive(chars);
                global::System.GC.KeepAlive(values);
            }
        }
    }
}

namespace Org.Apache.Commons.Lang3.Concurrent
{
    public partial class ThresholdCircuitBreaker : AbstractCircuitBreaker
    {
        public override bool IncrementAndCheckState(Java.Lang.Object p0)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class EventCountCircuitBreaker : AbstractCircuitBreaker
    {
        public override bool IncrementAndCheckState(Java.Lang.Object p0)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Text
{
    public partial class StrTokenizer : global::Java.Lang.Object, global::Java.Lang.ICloneable, IListIterator
    {
        public void Add(Java.Lang.Object e)
        {
            throw new System.NotImplementedException();
        }

        Java.Lang.Object IListIterator.Next()
        {
            throw new System.NotImplementedException();
        }

        Java.Lang.Object IListIterator.Previous()
        {
            throw new System.NotImplementedException();
        }

        public void Set(Java.Lang.Object e)
        {
            throw new System.NotImplementedException();
        }

        Java.Lang.Object IIterator.Next()
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class StrBuilder : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IAppendable, global::Java.Lang.ICharSequence, global::Org.Apache.Commons.Lang3.Builder.IBuilder
    {
        IAppendable IAppendable.Append(char c)
        {
            throw new System.NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq)
        {
            throw new System.NotImplementedException();
        }

        IAppendable IAppendable.Append(ICharSequence csq, int start, int end)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Builder
{
    public partial class ReflectionDiffBuilder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder
    {
        Java.Lang.Object IBuilder.Build()
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Tuple
{
    public partial class MutableTriple : Triple
    {
        protected override Java.Lang.Object RawLeft => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawMiddle => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawRight => throw new System.NotImplementedException();

        public override int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutablePair : Pair
    {
        protected override Java.Lang.Object RawLeft => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawRight => throw new System.NotImplementedException();

        public override int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed partial class ImmutableTriple : global::Org.Apache.Commons.Lang3.Tuple.Triple
    {
        protected override Java.Lang.Object RawLeft => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawMiddle => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawRight => throw new System.NotImplementedException();

        public override int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public sealed partial class ImmutablePair : global::Org.Apache.Commons.Lang3.Tuple.Pair
    {
        protected override Java.Lang.Object RawLeft => throw new System.NotImplementedException();

        protected override Java.Lang.Object RawRight => throw new System.NotImplementedException();

        public override int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Mutable
{
    public partial class MutableShort : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableLong : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableInt : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableFloat : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableDouble : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableBoolean : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial class MutableByte : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Math
{
    public sealed partial class Fraction : Number, global::Java.Lang.IComparable
    {
        public int CompareTo(Java.Lang.Object o)
        {
            throw new System.NotImplementedException();
        }
    }
}

namespace Org.Apache.Commons.Lang3.Time
{
    public partial class GmtTimeZone : global::Java.Util.TimeZone
    {
        public override int RawOffset { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}