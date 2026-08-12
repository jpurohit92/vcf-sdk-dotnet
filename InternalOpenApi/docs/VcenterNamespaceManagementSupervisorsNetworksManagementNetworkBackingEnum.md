# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksManagementNetworkBackingEnum
Vcenter.NamespaceManagement.Supervisors.Networks.Management.NetworkBackingEnum enumerates types of network backings supported by the Supervisor for the management network.  Possible values:   - `NETWORK`: This constant is deprecated as of __vSphere API 8.0.3.0__. Use *Vcenter.NamespaceManagement.Supervisors.Networks.Management.NetworkBackingEnum.NETWORK_SEGMENT* instead.  Indicates a virtual infrastructure management Network. It may include items like opaque networks or Distributed Virtual Port Groups.   - `NETWORK_SEGMENT`: Indicates a virtual infrastructure management Network Segment. The Network Segment can be backed by either a single Port Group or a set of Port Groups in the same layer 2 broadcast domain. From this set of one or more Port Groups, at least one Port Group must be available on each vSphere Zone and its associated vSphere clusters that Supervisor control plane is configured to be enabled on.  This constant was added in __vSphere API 8.0.3.0__.   This enumeration was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

