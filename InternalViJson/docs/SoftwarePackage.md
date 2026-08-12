# Vcenter.ViJson.OpenApi.Model.SoftwarePackage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Identifier that uniquely identifies the software package.  | 
**VarVersion** | **string** | Version string uniquely identifies this package.  | 
**Type** | **string** | Type of vib installed.  See *SoftwarePackageVibType_enum*.  | 
**Vendor** | **string** | The corporate entity that created this package.  | 
**AcceptanceLevel** | **string** | See also *HostImageAcceptanceLevel_enum*.  | 
**Summary** | **string** | A brief description of the package contents.  | 
**Description** | **string** | A full account of the package contents.  | 
**ReferenceURL** | **List&lt;string&gt;** | The list of SupportReference objects with in-depth support information.  | [optional] 
**CreationDate** | **DateTime** | The time when the package was installed.  On Autodeploy stateless installs there is no set value.  | [optional] 
**Depends** | [**List&lt;Relation&gt;**](Relation.md) | A list of VIBs that must be installed at the same time as this VIB.  | [optional] 
**Conflicts** | [**List&lt;Relation&gt;**](Relation.md) | A list of VIBs that cannot be installed at the same time as this VIB for a given version.  | [optional] 
**Replaces** | [**List&lt;Relation&gt;**](Relation.md) | A list of SoftwareConstraint objects that identify VIBs that replace this VIB or make it obsolete.  VIBs automatically replace VIBs with the same name but lower versions.  | [optional] 
**Provides** | **List&lt;string&gt;** | A list of virtual packages or interfaces this VIB provides.  | [optional] 
**MaintenanceModeRequired** | **bool** | True if hosts must be in maintenance mode for installation of this VIB.  | [optional] 
**HardwarePlatformsRequired** | **List&lt;string&gt;** | A list of hardware platforms this package is supported on.  | [optional] 
**Capability** | [**SoftwarePackageCapability**](SoftwarePackageCapability.md) | A set of optional attributes for this package.  | 
**Tag** | **List&lt;string&gt;** | A list of string tags for this package defined by the vendor or publisher.  Tags can be used to identify characteristics of a package.  | [optional] 
**Payload** | **List&lt;string&gt;** | A list of string tags to indicate one or more of what is contained: may be one of bootloader, upgrade, bootisobios, bootisoefi, vgz, tgz, boot or other values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

