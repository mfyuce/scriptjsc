// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.windows.forms;

@net.sf.jni4net.attributes.ClrType
public class Button extends system.windows.forms.Control {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Button(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public Button() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.windows.forms.Button.__ctorButton0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorButton0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/DialogResult;")
    public native system.Enum getDialogResult();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/DialogResult;)V")
    public native void setDialogResult(system.Enum value);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void NotifyDefault(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void PerformClick();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/AutoSizeMode;")
    public native system.Enum getAutoSizeMode();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/AutoSizeMode;)V")
    public native void setAutoSizeMode(system.Enum value);
    
    public static system.Type typeof() {
        return system.windows.forms.Button.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.windows.forms.Button.staticType = staticType;
    }
    //</generated-proxy>
}