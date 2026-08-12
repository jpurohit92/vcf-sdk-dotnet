# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationAvailabilityMode
Vcenter.NamespaceManagement.Networks.Edges.Foundation.AvailabilityMode describes the availability options for the load balancer.  Possible values:   - `ACTIVE_PASSIVE`: Deploys two nodes with one node responsible for serving traffic and the second node acting in standby. In the event that nodes cannot communicate with each other or are otherwise deemed unhealthy, a fail-over will occur and the passive node will begin serving traffic.    In the event of a fail-over, your workloads may be unavailable for a few seconds and connections to and from the load balancer may be reset.    Both nodes will be deployed to a single vSphere Zone in your Supervisor.   - `SINGLE_NODE`: Deploys a single node into a Supervisor vSphere Zone. A single node configuration trades availability to reduce resource consumption. In the event of a node failure, workloads will not be available until the node is able to be re-provisioned and configured. Re-provisioning happens automatically, but it is best-effort and requires a healthy cluster.    It is recommended you deploy with *Vcenter.NamespaceManagement.Networks.Edges.Foundation.AvailabilityMode.ACTIVE_PASSIVE* configuration if your Supervisor has enough resources.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

