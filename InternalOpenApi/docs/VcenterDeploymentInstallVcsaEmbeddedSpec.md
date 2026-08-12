# Vcenter.Automation.OpenApi.Model.VcenterDeploymentInstallVcsaEmbeddedSpec
The Vcenter.Deployment.Install.VcsaEmbeddedSpec schema contains information used to configure an embedded standalone or replicated vCenter Server.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Standalone** | [**VcenterDeploymentStandaloneSpec**](VcenterDeploymentStandaloneSpec.md) | Spec used to configure a standalone embedded vCenter Server.    This field describes how the standalone vCenter Server appliance should be configured.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will default to None.    | [optional] 
**Replicated** | [**VcenterDeploymentReplicatedSpec**](VcenterDeploymentReplicatedSpec.md) | Spec used to configure a replicated embedded vCenter Server.    This field describes how the replicated vCenter Server appliance should be configured.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will default to None.    | [optional] 
**CeipEnabled** | **bool** | Whether CEIP should be enabled or disabled.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

