# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksIPAssignmentAssignment
Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment lists the different entities that require IP ranges. These assignments fulfill different needs in the Kubernetes environment.  Possible values:   - `POD`: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.POD* represents the IP address that is allocatable to Kubernetes Pods. This assignment is currently only applicable on NSX networks.   - `NODE`: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.NODE* represents IP ranges that is allocated to nodes for both the control plane and Kubernetes Clusters. This assignment is currently only applicable on VDS networks.   - `SERVICE`: *Vcenter.NamespaceManagement.Networks.IPAssignment.Assignment.SERVICE* represents the IP ranges that Kubernetes can use for its cluster IP addresses. Cluster IPs are internal to the cluster, but can be exposed via edge services such as load balancer, ingress, and egress.   This enumeration was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

