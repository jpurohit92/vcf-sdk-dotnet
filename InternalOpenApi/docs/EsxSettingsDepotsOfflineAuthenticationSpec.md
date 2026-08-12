# Vcenter.Automation.OpenApi.Model.EsxSettingsDepotsOfflineAuthenticationSpec
The Esx.Settings.Depots.Offline.AuthenticationSpec schema contains properties that describe the authentication to be used for connecting to the remote depot. *Esx.Settings.Depots.Offline.CreateSpec* operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **string** | Specifies what method of authentication (AuthenticationMethod) is to be used when connecting to remote depot.  Possible values:   - &#x60;HEADER_AUTH&#x60;: HEADER_AUTH is intended to be used when connecting to a remote depot   For more information see: *Esx.Settings.Depots.Offline.AuthenticationSpec.AuthenticationMethod*.  This property was added in __vSphere API 9.0.0.0__. | 
**AuthenticationKey** | **string** | Specifies the authentication key to be used during the *POST /esx/settings/depots/offline* PULL operation.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of method is *Esx.Settings.Depots.Offline.AuthenticationSpec.AuthenticationMethod.HEADER_AUTH*. | [optional] 
**AuthenticationValue** | **string** | Specifies the authentication value of the authentication key to be used during the *POST /esx/settings/depots/offline* PULL operation.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of method is *Esx.Settings.Depots.Offline.AuthenticationSpec.AuthenticationMethod.HEADER_AUTH*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

