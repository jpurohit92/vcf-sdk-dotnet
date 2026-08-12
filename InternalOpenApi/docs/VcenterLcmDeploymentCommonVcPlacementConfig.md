# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonVcPlacementConfig
The Vcenter.Lcm.Deployment.Common.VcPlacementConfig schema contains configuration of VC placement of the target appliance.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmFolderPath** | **string** | Absolute path of the VM folder. VM folder must be visible by the Data Center of the compute resourceFormat:/{dc}/{vm_folder1}/{vm_folder2}e.g.:&#39;/DCenter/VM Folder 0/VM Folder1&#39;.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the default VM folder of the Datacenter will be used. | [optional] 
**ResourcePoolPath** | **string** | Absolute path to resource pool. Format: /{datacenter folder}/{datacenter name}/host/{host name}/{cluster_name}/Resources/{resource pool}. e.g: Your Datacenter Folder/Your Datacenter/host/Your Cluster/Resources/Your Resource Pool  This property was added in __vSphere API 9.0.0.0__.  Mutually exclusive between resource_pool_path, cluster_path, and host_path | [optional] 
**ClusterPath** | **string** | Absolute path to the cluster. Format: /{datacenter folder}/{datacenter name}/host/{cluster_name}. e.g: /Your Datacenter Folder/Your Datacenter/host/Your Cluster  This property was added in __vSphere API 9.0.0.0__.  Mutually exclusive between resource_pool_path, cluster_path, and host_path | [optional] 
**HostPath** | **string** | Absolute path of the ESX host (FQDN/IP) in the vCenter inventory tree.  This property was added in __vSphere API 9.0.0.0__.  Mutually exclusive between resource_pool_path, cluster_path, and host_path | [optional] 
**DatastoreName** | **string** | The datastore on which to store the files of the appliance. This value has to be either a specific datastore name, or a specific datastore in a datastore cluster. The datastore must have the space defined as appliance storage size.  This property was added in __vSphere API 9.0.0.0__.  Mutually exclusive between datastore_name and datastore_cluster_name | [optional] 
**DatastoreClusterName** | **string** | The datastore cluster on which to store the files of the appliance. The datastore cluster must have the space defined as appliance storage size.  This property was added in __vSphere API 9.0.0.0__.  Mutually exclusive between datastore_name and datastore_cluster_name | [optional] 
**NetworkName** | **string** | Name of the network. e.g. VM Network  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the target appliance will be deployed on the same network as current vCenter. If current vCenter is not self managed and source container is not specified, upgrade initialization will fail. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

