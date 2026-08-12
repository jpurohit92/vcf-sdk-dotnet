# Vcenter.ViJson.OpenApi.Model.HostHyperThreadScheduleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Available** | **bool** | The flag to indicate whether or not hyperthreading optimization is available on the system.  This property is set by VMware prior to installation.  | 
**Active** | **bool** | The flag to indicate whether or not the CPU scheduler is currently treating hyperthreads as schedulable resources.  Setting this property involves a successful invocation of either the *enableHyperThreading()* method (\&quot;true\&quot;) or the *disableHyperthreading()* method (\&quot;false\&quot;). The property is set once the system is rebooted.  | 
**Config** | **bool** | The flag to indicate whether or not the CPU scheduler should treat hyperthreads as schedulable resources the next time the CPU scheduler starts. - This property is set to \&quot;true\&quot; by successfully invoking the   *enableHyperThreading()* method. - This property is set to \&quot;false\&quot; by successfully invoking the   *disableHyperthreading()* method.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

