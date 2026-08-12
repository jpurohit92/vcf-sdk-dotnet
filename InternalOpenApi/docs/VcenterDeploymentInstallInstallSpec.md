# Vcenter.Automation.OpenApi.Model.VcenterDeploymentInstallInstallSpec
The Vcenter.Deployment.Install.InstallSpec schema contains information used to configure the appliance installation.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcsaEmbedded** | [**VcenterDeploymentInstallVcsaEmbeddedSpec**](VcenterDeploymentInstallVcsaEmbeddedSpec.md) | Spec used to configure an embedded vCenter Server. This field describes how the embedded vCenter Server appliance should be configured.  This property was added in __vSphere API 6.7__. | 
**AutoAnswer** | **bool** | Use the default option for any questions that may come up during appliance configuration.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, will default to false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

