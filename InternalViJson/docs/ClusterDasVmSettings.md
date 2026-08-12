# Vcenter.ViJson.OpenApi.Model.ClusterDasVmSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestartPriority** | **string** | Restart priority for a virtual machine.  If not specified at either the cluster level or the virtual machine level, this will default to &lt;code&gt;medium&lt;/code&gt;.  See also *ClusterDasVmSettingsRestartPriority_enum*.  | [optional] 
**RestartPriorityTimeout** | **int** | This setting is used to specify a maximum time the lower priority VMs should wait for the higher priority VMs to be ready.  If the higher priority Vms are not ready by this time, then the lower priority VMs are restarted irrespective of the VM ready state. This timeout can be used to prevent the failover of lower priority VMs to be stuck infinitely.  This timeout is not used if ready condition is *none*  Timeout specified in seconds. To use cluster setting for a VM override, set to -1 in per-VM. setting.  | [optional] 
**IsolationResponse** | **string** | Indicates whether or not the virtual machine should be powered off if a host determines that it is isolated from the rest of the compute resource.  If not specified at either the cluster level or the virtual machine level, this will default to &lt;code&gt;powerOff&lt;/code&gt;.  See also *ClusterDasVmSettingsIsolationResponse_enum*.  | [optional] 
**VmToolsMonitoringSettings** | [**ClusterVmToolsMonitoringSettings**](ClusterVmToolsMonitoringSettings.md) | Configuration for the VM Health Monitoring Service.  | [optional] 
**VmComponentProtectionSettings** | [**ClusterVmComponentProtectionSettings**](ClusterVmComponentProtectionSettings.md) | Configuration for the VM Component Protection Service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

