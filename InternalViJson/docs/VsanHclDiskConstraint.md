# Vcenter.ViJson.OpenApi.Model.VsanHclDiskConstraint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | Product ID of the disk drive.  E.g., AL15SEB120N  | 
**Vendor** | **string** | Vendor of the disk drive.  E.g., TOSHIBA  | 
**Constraints** | [**List&lt;VsanHclMinFwConstraint&gt;**](VsanHclMinFwConstraint.md) | VCG HCL constraints for the disk(SAS/SATA) drive.  In case the disk drive to query is not a SAS/SATA drive or not certified by VMware, this field will be empty.  | [optional] 
**PcieConstraints** | [**List&lt;VsanHclDeviceConstraint&gt;**](VsanHclDeviceConstraint.md) | VCG HCL constraints for the PCI-e based disk drive.  In case this disk drive is not a PCIe device or not certified by VMware, this field will be empty.  | [optional] 
**PartNumber** | **string** | Part number of the disk drive.  E.g., HDEBL02LPA51F. When it is present, it will replace the product id as the key identifier of the disk  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

