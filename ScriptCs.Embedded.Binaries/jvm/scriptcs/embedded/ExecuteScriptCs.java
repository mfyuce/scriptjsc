// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package scriptcs.embedded;

@net.sf.jni4net.attributes.ClrType
public class ExecuteScriptCs extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ExecuteScriptCs(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LCommon/Logging/ILog;LScriptCs/Contracts/IFileSystem;LScriptCs/Contracts/IPackageAssemblyResolver;LScriptCs/Contracts/IPackageInstaller;LScriptCs/Contracts/IScriptPackResolver;LScriptCs/Contracts/IScriptExecutor;LScriptCs/Contracts/IFilePreProcessor;)V")
    public ExecuteScriptCs(system.Object logger, system.Object fileSystem, system.Object packageAssemblyResolver, system.Object packageInstaller, system.Object scriptPackResolver, system.Object scriptExecutor, system.Object filePreprocessor) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        scriptcs.embedded.ExecuteScriptCs.__ctorExecuteScriptCs0(this, logger, fileSystem, packageAssemblyResolver, packageInstaller, scriptPackResolver, scriptExecutor, filePreprocessor);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V")
    private native static void __ctorExecuteScriptCs0(net.sf.jni4net.inj.IClrProxy thiz, system.Object logger, system.Object fileSystem, system.Object packageAssemblyResolver, system.Object packageInstaller, system.Object scriptPackResolver, system.Object scriptExecutor, system.Object filePreprocessor);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LScriptCs/Contracts/ScriptResult;")
    public native system.Object RunText(java.lang.String script);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LScriptCs/Contracts/ScriptResult;")
    public native system.Object RunFile(java.lang.String scriptPath);
    
    public static system.Type typeof() {
        return scriptcs.embedded.ExecuteScriptCs.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        scriptcs.embedded.ExecuteScriptCs.staticType = staticType;
    }
    //</generated-proxy>
}