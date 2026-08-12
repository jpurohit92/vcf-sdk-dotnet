# Vcenter.ViJson.OpenApi.Model.BatchAddStandaloneHostsRequestType
The parameters of *Folder.BatchAddStandaloneHosts_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewHosts** | [**List&lt;FolderNewHostSpec&gt;**](FolderNewHostSpec.md) | Specifies a list of host specifications for new hosts.  | [optional] 
**CompResSpec** | [**ComputeResourceConfigSpec**](ComputeResourceConfigSpec.md) | Specifies the configuration for the compute resource that will be created to contain all the hosts.  | [optional] 
**AddConnected** | **bool** | Flag to specify whether or not hosts should be connected at the time they are added. A host will not be added if a connection attempt is made and fails.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

