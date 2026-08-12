# Vcenter.Automation.OpenApi.Model.VcenterNamespacesMobilityVirtualmachinesImportsCustomizationSysprepUserData
The Vcenter.Namespaces.Mobility.Virtualmachines.Imports.CustomizationSysprepUserData schema contains the personal data pertaining to the owner of the virtual machine. The CustomizationSysprepUserData data object type maps to the UserData key in the sysprep.inf answer file. These values are transferred directly into the sysprep.inf file that VirtualCenter stores on the target virtual disk.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComputerName** | **string** | The computer_name property is the computer name of the Windows guest. Computer name may contain letters (A-Z), numbers(0-9), and hyphens (-) but no spaces or periods (.). The name may not consist entirely of digits. Computer name is limited to 15 characters in length due to a Windows restriction.  This property was added in __vSphere API 9.0.0.0__. | 
**FullName** | **string** | User&#39;s full name.  This property was added in __vSphere API 9.0.0.0__. | 
**OrgName** | **string** | User&#39;s organization.  This property was added in __vSphere API 9.0.0.0__. | 
**ProductId** | **string** | The product_id property is a valid serial number. Microsoft Sysprep requires that a valid serial number be included in the answer file when mini-setup runs. This serial number is ignored if the original guest operating system was installed using a volume-licensed CD.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

