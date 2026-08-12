# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksEdgesFoundationLoadBalancerUpdateAvailabilityMode
The Vcenter.NamespaceManagement.Supervisors.Networks.Edges.FoundationLoadBalancerUpdateAvailabilityMode defines parameters for update.  Possible values:   - `ACTIVE_PASSIVE`: Deploys two nodes with one node responsible for serving traffic and the second node acting in standby. In the event that nodes cannot communicate with each other or are otherwise deemed unhealthy, a fail-over will occur and the passive node will begin serving traffic.    In the event of a fail-over, your workloads may be unavailable for a few seconds and connections to and from the load balancer may be reset.    Both nodes will be deployed to a single vSphere Zone in your Supervisor.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

