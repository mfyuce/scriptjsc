//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScriptCs.Embedded {
    
    
    #region Component Designer generated code 
    public partial class ExecutionManager_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::ScriptCs.Embedded.@__ExecutionManager.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::ScriptCs.Embedded.ExecutionManager), typeof(global::ScriptCs.Embedded.ExecutionManager_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::ScriptCs.Embedded.ExecutionManager), typeof(global::ScriptCs.Embedded.ExecutionManager_))]
    internal sealed partial class @__ExecutionManager : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__ExecutionManager(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::ScriptCs.Embedded.@__ExecutionManager.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ExecutionManager);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "DestroyRuntime", "DestroyRuntime0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "InitRuntime", "InitRuntime1", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ExecuteFile", "ExecuteFile2", "(Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "ExecuteText", "ExecuteText3", "(Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetExceptionDetails", "GetExceptionDetails4", "(Lsystem/Exception;)Ljava/lang/String;"));
            return methods;
        }
        
        private static void DestroyRuntime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::ScriptCs.Embedded.ExecutionManager.DestroyRuntime();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void InitRuntime1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::ScriptCs.Embedded.ExecutionManager.InitRuntime();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ExecuteFile2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle file) {
            // (Ljava/lang/String;)Lsystem/Object;
            // (LSystem/String;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::ScriptCs.Embedded.ExecutionManager.ExecuteFile(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, file)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle ExecuteText3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle text) {
            // (Ljava/lang/String;)Lsystem/Object;
            // (LSystem/String;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, global::ScriptCs.Embedded.ExecutionManager.ExecuteText(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, text)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetExceptionDetails4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle exception) {
            // (Lsystem/Exception;)Ljava/lang/String;
            // (LSystem/Exception;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2JString(@__env, global::ScriptCs.Embedded.ExecutionManager.GetExceptionDetails(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, exception)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::ScriptCs.Embedded.@__ExecutionManager(@__env);
            }
        }
    }
    #endregion
}
