# Vcenter.ViJson.OpenApi.Model.NvdimmSystemInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Summary** | [**NvdimmSummary**](NvdimmSummary.md) | Host NVDIMM system summary.  Summary is unset if the system does not support PMem feature.  | [optional] 
**Dimms** | **List&lt;int&gt;** | List of NVDIMMs on the host.  NVDIMM list unset if the system does not support PMem feature.  | [optional] 
**DimmInfo** | [**List&lt;NvdimmDimmInfo&gt;**](NvdimmDimmInfo.md) | List of DIMM information of all NVDIMMs on the host.  Dimm information is unset if the system does not support PMem feature.  | [optional] 
**InterleaveSet** | **List&lt;int&gt;** | List of NVDIMM Interleave sets on the host.  Interleave set is unset if the system does not support PMem feature.  | [optional] 
**ISetInfo** | [**List&lt;NvdimmInterleaveSetInfo&gt;**](NvdimmInterleaveSetInfo.md) | List of information of all NVDIMM interleave sets on the host.  Interleave set information is unset if the system does not support PMem feature.  | [optional] 
**Namespace** | [**List&lt;NvdimmGuid&gt;**](NvdimmGuid.md) | List of NVDIMM namespaces on the host.  Namespace is unset if the system does not support PMem feature.  | [optional] 
**NsInfo** | [**List&lt;NvdimmNamespaceInfo&gt;**](NvdimmNamespaceInfo.md) | Deprecated as of vSphere 6.7u1, use nsDetails.  List of information of all NVDIMM namespaces on the host.  Namespace information is unset if the system does not support PMem feature.  | [optional] 
**NsDetails** | [**List&lt;NvdimmNamespaceDetails&gt;**](NvdimmNamespaceDetails.md) | List of details of all NVDIMM namespaces on the host.  Namespace details is unset if the system does not support PMem feature.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

