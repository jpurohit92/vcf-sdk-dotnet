# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCNSFileConfig
The Vcenter.NamespaceManagement.Supervisors.CNSFileConfig schema contains the specification required to set the configuration for Cloud Native Storage file volume support on Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VsanClusters** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Supervisors.CNSFileConfig.vsan_clusters* is a list of clusters to be used for provisioning file volumes.   As a prerequisite these clusters must have vSAN and vSAN file services enabled, and must be in the same vCenter as the Supervisor.   Currently this list must have a single entry which is the cluster identifier of the current cluster. This cluster must be a vSAN cluster and must have vSAN File Service enabled.   If a cluster in the list is not a vSAN cluster or does not have vSAN File Service enabled, an InvalidArgument error will be thrown from *POST /vcenter/namespace-management/clusters/{cluster}?action&#x3D;enable*, *PATCH /vcenter/namespace-management/clusters/{cluster}* and *PUT /vcenter/namespace-management/clusters/{cluster}* APIs.   An empty list may be specified to disable file volume support on the Supervisor.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

