//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.ComponentModel {
    
    
    #region Component Designer generated code 
    public partial class Component_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.ComponentModel.@__Component.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.ComponentModel.Component), typeof(global::System.ComponentModel.Component_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.ComponentModel.Component), typeof(global::System.ComponentModel.Component_))]
    internal sealed partial class @__Component : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Component(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.ComponentModel.@__Component.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Component);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Dispose", "Dispose0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSite", "Site1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setSite", "Site2", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addDisposed", "Disposed3", "(Lsystem/EventHandler;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeDisposed", "Disposed4", "(Lsystem/EventHandler;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getContainer", "Container5", "()Lsystem/IDisposable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorComponent0", "__ctorComponent0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static void Dispose0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            ((global::System.IDisposable)(@__real)).Dispose();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Site1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/ComponentModel/ISite;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.ComponentModel.ISite>(@__env, ((global::System.ComponentModel.IComponent)(@__real)).Site);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void Site2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/Object;)V
            // (LSystem/ComponentModel/ISite;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            ((global::System.ComponentModel.IComponent)(@__real)).Site = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.ComponentModel.ISite>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Disposed3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/EventHandler;)V
            // (LSystem/EventHandler;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            ((global::System.ComponentModel.IComponent)(@__real)).Disposed += global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.EventHandler>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void Disposed4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle value) {
            // (Lsystem/EventHandler;)V
            // (LSystem/EventHandler;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            ((global::System.ComponentModel.IComponent)(@__real)).Disposed -= global::net.sf.jni4net.utils.Convertor.StrongJ2CpDelegate<global::System.EventHandler>(@__env, value);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Container5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/IDisposable;
            // ()LSystem/ComponentModel/IContainer;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.ComponentModel.Component @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.ComponentModel.Component>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.ComponentModel.IContainer>(@__env, @__real.Container);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorComponent0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.ComponentModel.Component @__real = new global::System.ComponentModel.Component();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.ComponentModel.@__Component(@__env);
            }
        }
    }
    #endregion
}