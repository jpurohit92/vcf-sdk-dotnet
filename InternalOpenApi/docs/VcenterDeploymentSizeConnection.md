# Vcenter.Automation.OpenApi.Model.VcenterDeploymentSizeConnection
The Vcenter.Deployment.Size.Connection schema holds the information used to connect to a vCenter or ESXi.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The IP address or DNS resolvable name of the ESX/VC host. If a DNS resolvable name is provided, it must be resolvable from the source appliance.  This property was added in __vSphere API 9.1.0.0__. | 
**Username** | **string** | A username with administrative privileges on the ESX/VC host.  This property was added in __vSphere API 9.1.0.0__. | 
**Password** | **string** | The password of the *Vcenter.Deployment.Size.Connection.username* on the ESX/VC host.  This property was added in __vSphere API 9.1.0.0__. | 
**HttpsPort** | **long** | The port number for the ESX/VC.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to 443 | [optional] 
**SslVerify** | **bool** | A flag to indicate whether the ssl verification is required.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to True | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

