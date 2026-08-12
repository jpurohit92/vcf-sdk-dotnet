# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksEdgesFoundationLoadBalancerRuntime
Vcenter.NamespaceManagement.Supervisors.Networks.Edges.FoundationLoadBalancerRuntime contains the runtime state of the Foundation Load Balancer.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | [**List&lt;VcenterNamespaceManagementSupervisorsNetworksEdgesCondition&gt;**](VcenterNamespaceManagementSupervisorsNetworksEdgesCondition.md) | Contains a record of recent state transitions.    If the condition with the HEALTHY type has a status set to TRUE, then the system is operating normally. If the condition with the HEALTHY type has a status set to FALSE, then remediation may be required. If the condition with the HEALTHY type has a status set to UNKNOWN, then the system health could not be determined and remediation may be required.  This property was added in __vSphere API 9.0.0.0__. | 
**VarVersion** | **string** | The current version of the load balancer.    The version selected is determined by your vCenter version and Supervisor version.    __The load balancer is upgraded when your Supervisor is updated. Upgrades will cause your workloads to incur downtime. Thus, you should plan for workload downtime when upgrading your Supervisor.__  This property was added in __vSphere API 9.0.0.0__. | 
**VipsAllocated** | **long** | Total number of Virtual IP addresses currently allocated to services.  This property was added in __vSphere API 9.0.0.0__. | 
**VipsAvailable** | **long** | Total number of available Virtual IP addresses eligible to be used for load balancer services.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

