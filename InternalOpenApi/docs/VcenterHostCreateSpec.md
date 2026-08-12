# Vcenter.Automation.OpenApi.Model.VcenterHostCreateSpec
The Vcenter.Host.CreateSpec schema defines the information used to create a host.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The IP address or DNS resolvable name of the host. | 
**Port** | **long** | The port of the host.  If missing or &#x60;null&#x60;, port 443 will be used. | [optional] 
**UserName** | **string** | The administrator account on the host. | 
**Password** | **string** | The password for the administrator account on the host. | 
**Folder** | **string** | Host and cluster folder in which the new standalone host should be created.  This property is currently required. In the future, if this property is missing or &#x60;null&#x60;, the system will attempt to choose a suitable folder for the host; if a folder cannot be chosen, the host creation operation will fail.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Folder&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Folder&#x60;. | [optional] 
**ThumbprintVerification** | **string** | Type of host&#39;s SSL certificate verification to be done.  Possible values:   - &#x60;NONE&#x60;: Accept the host&#39;s thumbprint without verifying it.   - &#x60;THUMBPRINT&#x60;: Host&#39;s SSL certificate verified by checking its thumbprint against the specified thumbprint.   - &#x60;CERTIFICATE&#x60;: Host&#39;s SSL certificate verified by checking it against the provided PEM SSL certificate.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.Host.CreateSpec.ThumbprintVerification*. | 
**Thumbprint** | **string** | The thumbprint of the SSL certificate, which the host is expected to have. The thumbprint is always computed using the SHA1 hash and is the string representation of that hash in the format: xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx where, &#39;x&#39; represents a hexadecimal digit.  This property is optional and it is only relevant when the value of thumbprint_verification is *Vcenter.Host.CreateSpec.ThumbprintVerification.THUMBPRINT*. | [optional] 
**SslCertificate** | **string** | The SSL certificate in PEM format, which the host is expected to have.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of thumbprint_verification is *Vcenter.Host.CreateSpec.ThumbprintVerification.CERTIFICATE*. | [optional] 
**ForceAdd** | **bool** | Whether host should be added to the vCenter Server even if it is being managed by another vCenter Server. The original vCenterServer loses connection to the host.  If missing or &#x60;null&#x60;, forceAdd is default to false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

