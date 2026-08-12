# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsWorkloads
  Vcenter.NamespaceManagement.Supervisors.Workloads schema describes configuration that affects the behavior and lifecycle of Kubernetes workloads.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | [**VcenterNamespaceManagementSupervisorsNetworksWorkloadNetwork**](VcenterNamespaceManagementSupervisorsNetworksWorkloadNetwork.md) |   The workloads *Vcenter.NamespaceManagement.Supervisors.Workloads.network* describes configuration for the primary workload network.   Workloads will communicate with each other and will reach external networks over this network.   The IP ranges configured on this network are managed primarily within Kubernetes.  This property was added in __vSphere API 8.0.0.1__. | 
**Edge** | [**VcenterNamespaceManagementNetworksEdgesEdge**](VcenterNamespaceManagementNetworksEdgesEdge.md) |   *Vcenter.NamespaceManagement.Supervisors.Workloads.edge* configuration determines how network traffic will enter and leave the cluster.   The IP ranges configured on this network are managed by the Supervisor and the load balancer.  This property was added in __vSphere API 8.0.0.1__. | 
**KubeApiServerOptions** | [**VcenterNamespaceManagementSupervisorsKubeAPIServerOptions**](VcenterNamespaceManagementSupervisorsKubeAPIServerOptions.md) |   *Vcenter.NamespaceManagement.Supervisors.Workloads.kube_API_server_options* declares configuration options for the Kubernetes API Server.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, the default configuration will be used. | [optional] 
**Images** | [**VcenterNamespaceManagementSupervisorsImageSyncConfig**](VcenterNamespaceManagementSupervisorsImageSyncConfig.md) |   *Vcenter.NamespaceManagement.Supervisors.Workloads.images* specifies how images will be stored and pulled into the cluster.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, image sync configuration will default to the settings described within the Vcenter.NamespaceManagement.Supervisors.ImageSyncConfig schema. | [optional] 
**Storage** | [**VcenterNamespaceManagementSupervisorsWorkloadsStorageConfig**](VcenterNamespaceManagementSupervisorsWorkloadsStorageConfig.md) |   *Vcenter.NamespaceManagement.Supervisors.Workloads.storage* specifies which persistent storage is configured and accessible for workloads to consume. You can configure policies for both images and volumes.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, configuration will be copied from the control plane when possible. If not, some storage features may be unavailable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

