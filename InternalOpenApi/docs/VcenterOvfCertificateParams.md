# Vcenter.Automation.OpenApi.Model.VcenterOvfCertificateParams
The Vcenter.Ovf.CertificateParams schema contains information about the public key certificate used to sign the OVF package. This schema will only be returned if the OVF package is signed.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Issuer** | **string** | Certificate issuer. For example: /C&#x3D;US/ST&#x3D;California/L&#x3D;Palo Alto/O&#x3D;VMware, Inc.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Subject** | **string** | Certificate subject. For example: /C&#x3D;US/ST&#x3D;Massachusetts/L&#x3D;Hopkinton/O&#x3D;EMC Corporation/OU&#x3D;EMC Avamar/CN&#x3D;EMC Corporation.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**IsValid** | **bool** | Is the certificate chain validated.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**IsSelfSigned** | **bool** | Is the certificate self-signed.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**X509** | **string** | The X509 representation of the certificate.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Warnings** | [**List&lt;VcenterOvfWarningInfo&gt;**](VcenterOvfWarningInfo.md) | The list of warnings raised for the OVF certificate used in this OVF package deployment. Any warning that is not ignored by the client will cause the OVF package deployment to fail.  This property was added in __vSphere API 7.0.2.0__.  This property is set only if the certificate has warnings when retrieving information about an OVF package by *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action&#x3D;filter*. When the property is set, the *Vcenter.Ovf.WarningInfo.ignored* property can be updated before the OVF parameter is passed to *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action&#x3D;deploy* to deploy the OVF package. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

