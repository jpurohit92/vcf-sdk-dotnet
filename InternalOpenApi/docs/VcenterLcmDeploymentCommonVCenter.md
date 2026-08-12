# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonVCenter
The Vcenter.Lcm.Deployment.Common.VCenter schema contains VC configuration that should be used for deployment.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Connection** | [**VcenterLcmDeploymentCommonConnection**](VcenterLcmDeploymentCommonConnection.md) | The configuration to connect to a VCenter.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the target appliance will be deployed on the location specified in *Vcenter.Lcm.Deployment.Common.VCenter.placement_config* on the current vCenter. | [optional] 
**PlacementConfig** | [**VcenterLcmDeploymentCommonVcPlacementConfig**](VcenterLcmDeploymentCommonVcPlacementConfig.md) | The location of the new version of the vCSA on the desired vCenter.    All names are case-sensitive. you can install the appliance to one of the following destinations: 1. A resource pool in a cluster, use &#39;cluster_path&#39;. 2. A specific ESX host in a cluster, use &#39;host_path&#39;. 3. A resource pool in a specific ESX host being managed by the current vCenter, use &#39;resource_pool_path&#39;. 4. To install a new appliance to a specific ESX host in a cluster, provide the &#39;host_path&#39; key, and the &#39;datastore_name&#39;, e.g. &#39;host_path&#39;: &#39;/MyDataCenter/host/MyCluster/10.20.30.40&#39;, &#39;datastore_name&#39;: &#39;Your Datastore&#39;. 5. To install a new appliance to a specific resource pool, provide the &#39;resource_pool_path&#39;, and the &#39;datastore_name&#39;, e.g. &#39;resource_pool_path&#39;: &#39;/Your Datacenter Folder/Your Datacenter/host/Your Cluster/Resources/Your Resource Pool&#39;, &#39;datastore_name&#39;: &#39;Your Datastore&#39;. 6. To place a new appliance to a virtual machine Folder, provide the &#39;vm_folder_path&#39;, e.g. vm_folder_path&#39;: &#39;VM Folder 0/VM Folder1&#39;.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

