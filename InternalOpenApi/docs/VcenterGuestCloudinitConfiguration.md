# Vcenter.Automation.OpenApi.Model.VcenterGuestCloudinitConfiguration
Guest customization settings to customize a Linux guest operating system with raw cloud-init data.    The Vcenter.Guest.CloudinitConfiguration schema contains settings that configure a Linux machine with raw cloud-init data. See https://cloudinit.readthedocs.io/en/latest about cloud-init.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | **string** | Metadata includes the network, instance id and hostname that cloud-init processes to configure the virtual machine. It is in json or yaml format. The max size of the metadata is 524288 bytes. See https://cloudinit.readthedocs.io/en/latest/topics/datasources/ovf.html about supported meta data formats.  This property was added in __vSphere API 7.0.3.0__. | 
**Userdata** | **string** | Userdata is the user customized content that cloud-init processes to configure the virtual machine. See https://cloudinit.readthedocs.io/en/latest/topics/format.html about user data formats. See https://cloudinit.readthedocs.io/en/latest/topics/modules.html# about user data modules. The max size of the userdata is 524288 bytes.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no cloud-init user data will be used as part of the cloud-init configuration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

