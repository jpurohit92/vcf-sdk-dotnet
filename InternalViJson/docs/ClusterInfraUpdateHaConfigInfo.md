# Vcenter.ViJson.OpenApi.Model.ClusterInfraUpdateHaConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not the service is enabled.  InfraUpdateHA will not be active, unless DRS is enabled as well.  | [optional] 
**Behavior** | **string** | Configured behavior.  Values are of type *BehaviorType*.  | [optional] 
**ModerateRemediation** | **string** | Configured remediation for moderately degraded hosts.  Values are of type *RemediationType*. Configuring MaintenanceMode for moderateRemedation and QuarantineMode for severeRemediation is not supported and will throw InvalidArgument.  | [optional] 
**SevereRemediation** | **string** | Configured remediation for severely degraded hosts.  Values are of type *RemediationType*.  | [optional] 
**Providers** | **List&lt;string&gt;** | The list of health update providers configured for this cluster.  Providers are identified by their id.  When reconfiguring the cluster, a list with a single element {\&quot;\&quot;} will clear the list of providers.  If the provider list is empty, InfraUpdateHA will not be active.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

