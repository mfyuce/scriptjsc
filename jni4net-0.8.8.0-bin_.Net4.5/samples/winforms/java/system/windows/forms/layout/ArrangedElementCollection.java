// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.windows.forms.layout;

@net.sf.jni4net.attributes.ClrType
public class ArrangedElementCollection extends system.Object implements system.collections.IList, system.collections.ICollection, system.collections.IEnumerable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ArrangedElementCollection(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    protected ArrangedElementCollection() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Collections/IEnumerator;")
    public native system.collections.IEnumerator GetEnumerator();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Array;I)V")
    public native void CopyTo(system.Array array, int index);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getCount();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object getSyncRoot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSynchronized();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)LSystem/Object;")
    public native system.Object getItem(int index);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Object;)V")
    public native void setItem(int index, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int Add(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)Z")
    public native boolean Contains(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void Clear();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isReadOnly();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isFixedSize();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int IndexOf(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(ILSystem/Object;)V")
    public native void Insert(int index, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)V")
    public native void Remove(system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native void RemoveAt(int index);
    
    public static system.Type typeof() {
        return system.windows.forms.layout.ArrangedElementCollection.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.windows.forms.layout.ArrangedElementCollection.staticType = staticType;
    }
    //</generated-proxy>
}