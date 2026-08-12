# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOfflineConnectionSpec
The Esx.Settings.Depots.Offline.ConnectionSpec schema contains properties that describe the specification to be used for connecting to the host during the *POST /esx/settings/depots/offline?action=createFromHost* operation.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthType** | **string** | Specifies what type of authentication (AuthenticationType) is to be used when connecting with the host. USERNAME_PASSWORD is intended to be used when connecting to a host that is not currently part of the vCenter inventory. EXISTING is intended for hosts that are in vCenter inventory, in which case, HostServiceTicket will be used to connect to the host.  Possible values:   - &#x60;USERNAME_PASSWORD&#x60;: Connect to host using host&#39;s credentials *Esx.Settings.Depots.Offline.HostCredentials* schema.   - &#x60;EXISTING&#x60;: Connect to the host using service ticket. Note: This is supported only for hosts present in the VC inventory.   For more information see: *Esx.Settings.Depots.Offline.ConnectionSpec.AuthenticationType*.  This property was added in __vSphere API 7.0.2.0__. | 
**HostCredential** | [**EsxSettingsDepotsOfflineHostCredentials**](EsxSettingsDepotsOfflineHostCredentials.md) | Specifies the host details to be used during the *POST /esx/settings/depots/offline?action&#x3D;createFromHost* operation.  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of auth_type is *Esx.Settings.Depots.Offline.ConnectionSpec.AuthenticationType.USERNAME_PASSWORD*. | [optional] 
**Host** | **string** | Specifies the host Managed Object ID to be used during the *POST /esx/settings/depots/offline?action&#x3D;createFromHost* operation.  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of auth_type is *Esx.Settings.Depots.Offline.ConnectionSpec.AuthenticationType.EXISTING*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

