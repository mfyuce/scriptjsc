// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.builder.conf;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class KnowledgeBuilderOptionsConfiguration_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __KnowledgeBuilderOptionsConfiguration extends system.Object implements org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration {
    
    protected __KnowledgeBuilderOptionsConfiguration(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lorg/drools/builder/conf/KnowledgeBuilderOption;)V")
    public native void setOption(org.drools.builder.conf.KnowledgeBuilderOption par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/builder/conf/MultiValueKnowledgeBuilderOption;")
    public native org.drools.builder.conf.MultiValueKnowledgeBuilderOption getOption(java.lang.Class par0, java.lang.String par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Class;)Lorg/drools/builder/conf/SingleValueKnowledgeBuilderOption;")
    public native org.drools.builder.conf.SingleValueKnowledgeBuilderOption getOption(java.lang.Class par0);
}
//</generated-proxy>
