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
public class ScrollableControl extends system.windows.forms.Control {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ScrollableControl(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public ScrollableControl() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        system.windows.forms.ScrollableControl.__ctorScrollableControl0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorScrollableControl0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean getAutoScroll();
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void setAutoScroll(boolean value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Drawing/Size;")
    public native system.drawing.Size getAutoScrollMargin();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Drawing/Size;)V")
    public native void setAutoScrollMargin(system.drawing.Size value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Drawing/Point;")
    public native system.drawing.Point getAutoScrollPosition();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Drawing/Point;)V")
    public native void setAutoScrollPosition(system.drawing.Point value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Drawing/Size;")
    public native system.drawing.Size getAutoScrollMinSize();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Drawing/Size;)V")
    public native void setAutoScrollMinSize(system.drawing.Size value);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/HScrollProperties;")
    public native system.Object getHorizontalScroll();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/VScrollProperties;")
    public native system.Object getVerticalScroll();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Windows/Forms/ScrollableControl+DockPaddingEdges;")
    public native system.Object getDockPadding();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/Control;)V")
    public native void ScrollControlIntoView(system.windows.forms.Control activeControl);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/ScrollEventHandler;)V")
    public native void addScroll(system.MulticastDelegate value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Windows/Forms/ScrollEventHandler;)V")
    public native void removeScroll(system.MulticastDelegate value);
    
    @net.sf.jni4net.attributes.ClrMethod("(II)V")
    public native void SetAutoScrollMargin(int x, int y);
    
    public static system.Type typeof() {
        return system.windows.forms.ScrollableControl.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.windows.forms.ScrollableControl.staticType = staticType;
    }
    //</generated-proxy>
}