# Vcenter.ViJson.OpenApi.Model.ClusterDpmConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Flag indicating whether or not the service is enabled.  This service can not be enabled, unless DRS is enabled as well.  | [optional] 
**DefaultDpmBehavior** | **DpmBehaviorEnum** | Specifies the default VMware DPM behavior for hosts.  This default behavior can be overridden on a per host basis using the *ClusterDpmHostConfigInfo* object.  | [optional] 
**HostPowerActionRate** | **int** | DPM generates only those recommendations that are above the specified rating.  Ratings vary from 1 to 5. This setting applies to both manual and automated (@link DpmBehavior) DPM clusters.  | [optional] 
**Option** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Deprecated as of vSphere API 4.1, use *ClusterDrsConfigInfo.option*.  Advanced settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

