# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsClusterSolutionInfo
The Esx.Settings.Clusters.Vms.Solutions.ClusterSolutionInfo schema contains properties that describe solution configuration only applicable for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmCount** | **long** | The number of instances of the specified VM to be deployed across the cluster.  This property was added in __vSphere API 9.0.0.0__. | 
**VmPlacementPolicies** | **List&lt;string&gt;** | VM placement policies to be configured on the VMs.  Possible values:   - &#x60;VM_VM_ANTI_AFFINITY&#x60;: VMs are anti-affined to each other.   For more information see: *Esx.Settings.Clusters.Vms.VmPlacementPolicy*.  This property was added in __vSphere API 9.0.0.0__. | 
**VmNetworks** | **Dictionary&lt;string, string&gt;** | Networks to be configured on the VMs. The map keys represent the logical network names defined in the OVF descriptor while the map values represent the VM network identifiers.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the value in the property map must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the value in the property map will be an identifier for the resource type: &#x60;Network&#x60;. | 
**VmDatastores** | **List&lt;string&gt;** | Datastores to be configured as a storage of the VMs. The first datastore from the list available in the cluster is used.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datastore&#x60;. | 
**Devices** | **Object** | Devices of the VMs not defined in the OVF descriptor.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; no additional devices will be added to the VMs. | [optional] 
**RemediationPolicy** | **string** | Remediation policy to be configured for the deployment units.  Possible values:   - &#x60;PARALLEL&#x60;: Default remediation policy. Entities are remediated in parallel.   - &#x60;SEQUENTIAL&#x60;: Entities are remediated sequentially, one at a time.   For more information see: *Esx.Settings.Clusters.Vms.RemediationPolicy*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**AlternativeVmSpecs** | [**List&lt;EsxSettingsClustersVmsAlternativeVmSpec&gt;**](EsxSettingsClustersVmsAlternativeVmSpec.md) | List of Esx.Settings.Clusters.Vms.AlternativeVmSpecs to be applied on the System VMs.     This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; no Esx.Settings.Clusters.Vms.AlternativeVmSpecs will be applied to the System VMs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

