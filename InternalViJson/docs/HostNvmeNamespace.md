# Vcenter.ViJson.OpenApi.Model.HostNvmeNamespace

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  This is a unique identifier of the NVME namespace within the host system.  | 
**Name** | **string** | The name of the namespace.  The name identifies the underlying storage exposed by the NvmeNamespace. In multipath scenarios, two namespaces can have the same name if they expose the same underlying storage through different NVME controllers.  | 
**Id** | **int** | The namespace ID is an identifier used by an NVME controller to provide access to a namespace.  The namespace ID is only unique among the namespaces attached to the same controller. For details, see: - \&quot;NVM Express 1.3\&quot;, section 6.1, \&quot;Namespaces\&quot;.  | 
**BlockSize** | **int** | Block size of the namespace in bytes.  Namespaces are comprised of a number of logical blocks with a fixed size - the smallest units of data that may be read or written by the NVME controller.  | 
**CapacityInBlocks** | **long** | The maximum number of logical blocks that may be allocated in the namespace at any point in time.  Corresponds to the NCAP field in the Identify Namespace data structure: - \&quot;NVM Express 1.3\&quot;, Section 5.15, Figure 114,   \&quot;Identify Namespace Data Structure\&quot;  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

