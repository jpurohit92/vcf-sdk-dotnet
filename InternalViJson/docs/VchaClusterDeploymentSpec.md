# Vcenter.ViJson.OpenApi.Model.VchaClusterDeploymentSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassiveDeploymentSpec** | [**PassiveNodeDeploymentSpec**](PassiveNodeDeploymentSpec.md) | Deployment spec for the Passive node  | 
**WitnessDeploymentSpec** | [**NodeDeploymentSpec**](NodeDeploymentSpec.md) | Deployment spec for the Witness node  | 
**ActiveVcSpec** | [**SourceNodeSpec**](SourceNodeSpec.md) | Active vCenter Server specification required to deploy VCHA Cluster.  | 
**ActiveVcNetworkConfig** | [**ClusterNetworkConfigSpec**](ClusterNetworkConfigSpec.md) | The Cluster network config spec allows creation and configuration of the second Network adapter of the Active or Source VCenter.  The second network adapter is used for communication between the nodes of a VCHA cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

