# Vcenter.ViJson.OpenApi.Model.AddStandaloneHostRequestType
The parameters of *Folder.AddStandaloneHost_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**HostConnectSpec**](HostConnectSpec.md) | Specifies the parameters needed to add a single host.  | 
**CompResSpec** | [**ComputeResourceConfigSpec**](ComputeResourceConfigSpec.md) | Optionally specify the configuration for the compute resource that will be created to contain the host.  | [optional] 
**AddConnected** | **bool** | Flag to specify whether or not the host should be connected as soon as it is added. The host will not be added if a connection attempt is made and fails.  | 
**License** | **string** | Provide a licenseKey or licenseKeyType. See *LicenseManager*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

