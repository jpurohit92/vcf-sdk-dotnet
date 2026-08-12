# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksMode
The Vcenter.NamespaceManagement.Networks.Mode enumerated type describes the intended use of a network.  Possible values:   - `MANAGEMENT`: Indicates the infrastructure supports connectivity between this network and the Supervisor management network. Entities on this network are capable of communicating with management entities like the Supervisor and vCenter Server.    Networks can only be associated to *Vcenter.NamespaceManagement.Networks.Mode.MANAGEMENT* networks when the Supervisor management network is configured to be the Primary Workload Network.   - `WORKLOAD`: Indicates the network is intended for general workload consumption. This network should generally not be routable to networks with the *Vcenter.NamespaceManagement.Networks.Mode.MANAGEMENT* mode set.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

