﻿

SELECT name, is_broker_enabled FROM sys.databases;

ALTER DATABASE DRRMOFingerprintDB SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE;