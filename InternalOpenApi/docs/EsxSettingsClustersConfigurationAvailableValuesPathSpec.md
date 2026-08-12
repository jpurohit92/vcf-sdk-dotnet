# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationAvailableValuesPathSpec
The Esx.Settings.Clusters.Configuration.AvailableValues.PathSpec schema contains properties that describe the input for path for which available values need to be computed.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostIdType** | **string** | Type of host ID.  Possible values:   - &#x60;BIOS_UUID&#x60;: The identifier represents bios uuid of ESXi host.   - &#x60;HOST_MOID&#x60;: The identifier represents host moid of ESXi host.   For more information see: *Esx.Settings.Clusters.Configuration.AvailableValues.PathSpec.HostIdType*.  This property was added in __vSphere API 9.1.0.0__.  This field is set only for host specific paths to specify the type of host ID, either host moId or BIOS UUID. | [optional] 
**Hosts** | **List&lt;string&gt;** | List of host moids  This property was added in __vSphere API 9.1.0.0__.  This field is set to specify host moids in the cluster for which available values need to be computed for a path that represents host specific config.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**BiosUuids** | **List&lt;string&gt;** | List of host BIOS UUIDs  This property was added in __vSphere API 9.1.0.0__.  This field is set to specify BIOS UUIDs in the cluster for which available values need to be computed for a path that represents host specific config.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**InputSpec** | **string** | Input spec, encoded as JSON.  This property was added in __vSphere API 9.1.0.0__.  This field is set to provide a input spec that shall be used to compute available values for given path. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

