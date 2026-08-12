# Vcenter.Automation.OpenApi.Model.VcenterGuestDomain
The Vcenter.Guest.Domain schema specifies the information needed to join a workgroup or domain. This structure maps to the Identification key in the sysprep.xml answer file. These values are transferred into the sysprep.xml file that VirtualCenter stores on the target virtual disk. For more information about performing unattended installation, check https://technet.microsoft.com/en-us/library/cc771830(v=ws.10).aspx  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of network to join after the customization.  Possible values:   - &#x60;WORKGROUP&#x60;: The virtual machine should be be joined to a workgroup.   - &#x60;DOMAIN&#x60;: The virtual machine should be be joined to a domain.   For more information see: *Vcenter.Guest.Domain.Type*.  This property was added in __vSphere API 7.0.0.0__. | 
**Workgroup** | **string** | The workgroup that the virtual machine should join.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Domain.Type.WORKGROUP*. | [optional] 
**Domain** | **string** | The domain to which the virtual machine should be joined.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Domain.Type.DOMAIN*. | [optional] 
**DomainUsername** | **string** | The domain user that has permission to join the domain after virtual machine is joined.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Domain.Type.DOMAIN*. | [optional] 
**DomainPassword** | **string** | The domain user password that has permission to join the *Vcenter.Guest.Domain.domain_username* after customization.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Domain.Type.DOMAIN*. | [optional] 
**DomainOu** | **string** | The MachineObjectOU which specifies the full LDAP path name of the OU to which the virtual machine belongs. Refer to: https://docs.microsoft.com/en-us/windows-hardware/customize desktop/unattend/microsoft-windows-unattendedjoin- identification-machineobjectou  This property was added in __vSphere API 8.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.Domain.Type.DOMAIN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

