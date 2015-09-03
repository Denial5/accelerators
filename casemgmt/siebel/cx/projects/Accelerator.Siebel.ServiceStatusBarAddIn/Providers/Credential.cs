﻿/* *********************************************************************************************
 *  This file is part of the Oracle Service Cloud Accelerator Reference Integration set published
 *  by Oracle Service Cloud under the MIT license (MIT) included in the original distribution.
 *  Copyright (c) 2014, 2015, Oracle and/or its affiliates. All rights reserved.
 ***********************************************************************************************
 *  Accelerator Package: OSVC Contact Center + Siebel Case Management Accelerator
 *  link: http://www.oracle.com/technetwork/indexes/samplecode/accelerator-osvc-2525361.html
 *  OSvC release: 15.5 (May 2015)
 *  Siebel release: 8.1.1.15
 *  reference: 141216-000121
 *  date: Wed Sep  2 23:14:42 PDT 2015

 *  revision: rnw-15-8-fixes-release-01
 *  SHA1: $Id: 108789cfd309f41265635d4630e20181c953e187 $
 * *********************************************************************************************
 *  File: Credential.cs
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accelerator.Siebel.SharedServices.Providers
{
    public sealed class Credential
    {
        private String _password;

        private String _username;
        public String password
        {
            get { return _password; }
            set { _password = value; }
        }

        public String username
        {
            get { return _username; }
            set { _username = value; }
        } 
    }
}