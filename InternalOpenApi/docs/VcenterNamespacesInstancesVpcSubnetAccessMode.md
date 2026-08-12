# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVpcSubnetAccessMode
The Vcenter.Namespaces.Instances.VpcSubnetAccessMode enumerates the default access modes of NSX VPC Subnets hosting resources created in namespaces.  Possible values:   - `PUBLIC`: *Vcenter.Namespaces.Instances.VpcSubnetAccessMode.PUBLIC* indicates new Subnets are allocated from *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile* external IP blocks and are routable from external networks.   - `PRIVATE_TGW`: *Vcenter.Namespaces.Instances.VpcSubnetAccessMode.PRIVATE_TGW* indicates new Subnets are allocated from *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile* project IP blocks and are routable within other VPCs from the same project.   - `PRIVATE`: *Vcenter.Namespaces.Instances.VpcSubnetAccessMode.PRIVATE* indicates new Subnets are allocated from *Vcenter.Namespaces.Instances.VpcConfig.private_cidrs* and are routable only within the same VPC.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

