# Vcenter.ViJson.OpenApi.Model.HostNvmeTopologyInterface

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The identifier for the NVME interface.  | 
**Adapter** | **string** | The link to data for the NVME interface.  | 
**ConnectedController** | [**List&lt;HostNvmeController&gt;**](HostNvmeController.md) | The list of connected NVME controllers.  This list can be empty if am NVME interface is not connected to any controllers. Each NvmeController object contains a list of its attached NVME namespaces in *HostNvmeController.attachedNamespace*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

