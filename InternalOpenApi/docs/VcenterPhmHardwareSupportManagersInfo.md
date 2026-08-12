# Vcenter.Automation.OpenApi.Model.VcenterPhmHardwareSupportManagersInfo
The Vcenter.Phm.HardwareSupportManagers.Info schema contains an existing hardware support manager registration data, see *GET /vcenter/phm/hardware-support-managers/{key}*.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseUrl** | **string** | The full URL path for all HSM endpoints. (e.g. https://{hsm_api_host}/vsphere-proactive-hw-mgmt)  This property was added in __vSphere API 8.0.3.0__. | 
**ServerCertificate** | **string** | The full unabbreviated certificate used by HSM API host in PEM format. The PEM string must contain only the end-entity (leaf) certificate of the certificate chain of trust. It must NOT contain any private keys or anything else except a single x509 certificate.  This property was added in __vSphere API 8.0.3.0__. | 
**HealthUpdateInfoDefaultConfigs** | [**List&lt;VcenterPhmHardwareSupportManagersHealthUpdateInfoConfig&gt;**](VcenterPhmHardwareSupportManagersHealthUpdateInfoConfig.md) | The default configuration on a list of supported Vcenter.Phm.HardwareSupportManagers.HealthUpdateInfo and their enablements.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

