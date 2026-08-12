# Vcenter.Automation.OpenApi.Model.ApplianceTlsProfilesListItem
The Appliance.Tls.Profiles.ListItem schema contains the information about the standard profile name and their TLS configuration.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | **string** | Defines the standard profile name.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.tls.profiles&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.tls.profiles&#x60;. | 
**Info** | [**ApplianceTlsProfilesInfo**](ApplianceTlsProfilesInfo.md) | Contains information about the TLS Profile configuration.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

