# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterHealthSummaryRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummary*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  Refers instance of *ClusterComputeResource*.  | [optional] 
**VmCreateTimeout** | **int** |  | [optional] 
**ObjUuids** | **List&lt;string&gt;** |  | [optional] 
**IncludeObjUuids** | **bool** | Whether to include detailed per-object health in the result. Default to True. Set to false if this value is not of importance to save computing resources.  | [optional] 
**Fields** | **List&lt;string&gt;** | If set, only the properties listed in the array are returned in the result data object. Normally the output of this API can be quite large so this allows clients which are only interested in a subset to save network bandwidth and deserialization effort. The possible value is the field from the VsanClusterHealthSummary class like &#39;objectHealth&#39;, &#39;networkHealth&#39; etc If unset, following properties are included in the result. &#39;clusterStatus&#39;, &#39;timestamp&#39;, &#39;clusterVersions&#39;, &#39;objectHealth&#39;, &#39;vmHealth&#39;, &#39;networkHealth&#39;, &#39;limitHealth&#39;, &#39;advCfgSync&#39;, &#39;createVmHealth&#39;, &#39;physicalDisksHealth&#39;, &#39;hclInfo&#39;, &#39;groups&#39;, &#39;overallHealth&#39;, &#39;overallHealthDescription&#39;, &#39;clomdLiveness&#39;, &#39;diskBalance&#39;  | [optional] 
**FetchFromCache** | **bool** | True to return the result from cache directly instead of running the full health check. The cache will be updated and keep the latest vSAN health summary check result either triggering from user on-demand request or the periodical vSAN health check for triggering health event/alarm. Default is False.  | [optional] 
**Perspective** | **string** | The total amount of health checks is split into multiple different perspectives. This parameter controls which health checks are performed/returned. All supported values are defined in below enumerations: *VsanHealthPerspective_enum*, *VsanHealthPerspective90_enum*.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Include the individual host(s) into the health check, with other hosts specified with the cluster parameter.  Refers instances of *HostSystem*.  | [optional] 
**Spec** | [**VsanClusterHealthQuerySpec**](VsanClusterHealthQuerySpec.md) | Health summary query specification *VsanClusterHealthQuerySpec*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

