# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksIPAssignment
Vcenter.NamespaceManagement.Networks.IPAssignment schema is used to assign IP addresses to be used for various functions in a Supervisor Kubernetes Cluster.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assignee** | **string** | *Vcenter.NamespaceManagement.Networks.IPAssignment.assignee* is the role assignee for the given IP Ranges.  Possible values:   - &#x60;POD&#x60;: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.POD* represents the IP address that is allocatable to Kubernetes Pods. This assignment is currently only applicable on NSX networks.   - &#x60;NODE&#x60;: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.NODE* represents IP ranges that is allocated to nodes for both the control plane and Kubernetes Clusters. This assignment is currently only applicable on VDS networks.   - &#x60;SERVICE&#x60;: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.SERVICE* represents the IP ranges that Kubernetes can use for its cluster IP addresses. Cluster IPs are internal to the cluster, but can be exposed via edge services such as load balancer, ingress, and egress.   For more information see: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment*.  This property was added in __vSphere API 8.0.0.1__.  This field defaults to ANY. | [optional] 
**Ranges** | [**List&lt;VcenterNamespaceManagementNetworksIPRange&gt;**](VcenterNamespaceManagementNetworksIPRange.md) | *Vcenter.NamespaceManagement.Networks.IPAssignment.ranges* lists the available IP addresses that can be consumed by Supervisor to run the cluster.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

