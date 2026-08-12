# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNetworksNsxVpcSubnetAccessMode
The Vcenter.Namespaces.Networks.Nsx.VpcSubnetAccessMode enumerates the default access modes of NSX VPC subnets hosting resources created in namespaces.  Possible values:   - `PUBLIC`: *Vcenter.Namespaces.Networks.Nsx.VpcSubnetAccessMode.PUBLIC* indicates new subnets are allocated from *Vcenter.Namespaces.Networks.Nsx.VpcConnectivityProfileInfo.external_IP_blocks* and are routable from external networks.   - `PRIVATE_TGW`: *Vcenter.Namespaces.Networks.Nsx.VpcSubnetAccessMode.PRIVATE_TGW* indicates new subnets are allocated from *Vcenter.Namespaces.Networks.Nsx.VpcConnectivityProfileInfo.privateTGW_IP_blocks* and are routable within other VPCs from the same project.   - `PRIVATE`: *Vcenter.Namespaces.Networks.Nsx.VpcSubnetAccessMode.PRIVATE* indicates new subnets are allocated from private CIDRs and are routable only within the same VPC.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

