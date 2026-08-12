# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersNCPClusterNetworkInfo
The Vcenter.NamespaceManagement.Clusters.NCPClusterNetworkInfo schema contains the NSX Container Plugin-specific cluster networking configuration.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PodCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | CIDR blocks from which Kubernetes allocates pod IP addresses.  This property was added in __vSphere API 7.0.0.0__. | 
**IngressCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.  This property was added in __vSphere API 7.0.0.0__. | 
**EgressCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs.  This property was added in __vSphere API 7.0.0.0__. | 
**ClusterDistributedSwitch** | **string** |   vSphere Distributed Switch used to connect this cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. | 
**NsxEdgeCluster** | **string** | NSX Edge cluster to be used for Kubernetes Services of type LoadBalancer, Kubernetes Ingresses, and NSX SNAT.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. | 
**DefaultIngressTlsCertificate** | **string** | PEM-encoded x509 certificate used by NSX as a default fallback certificate for Kubernetes Ingress services.  This property was added in __vSphere API 7.0.0.0__. | 
**NsxTier0Gateway** | **string** | NSX Tier0 Gateway used for this Supervisor.  This property was added in __vSphere API 7.0.2.0__.  This is set when the cluster uses NSX.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. | [optional] 
**NamespaceSubnetPrefix** | **long** | Size of the subnet reserved for namespaces segments.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, defaults to 28. | [optional] 
**RoutedMode** | **bool** | Routed mode for this Supervisor.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, defaults to False. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

