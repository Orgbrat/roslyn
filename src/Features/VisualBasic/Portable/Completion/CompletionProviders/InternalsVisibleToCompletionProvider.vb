﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Threading
Imports Microsoft.CodeAnalysis.Completion.Providers

Namespace Microsoft.CodeAnalysis.VisualBasic.Completion.Providers

    Friend NotInheritable Class InternalsVisibleToCompletionProvider
        Inherits AbstractInternalsVisibleToCompletionProvider

        Protected Overrides Function IsPositionEntirelyWithinStringLiteral(syntaxTree As SyntaxTree, position As Integer, cancellationToken As CancellationToken) As Boolean
            Return syntaxTree.IsEntirelyWithinStringLiteral(position, cancellationToken)
        End Function
    End Class
End Namespace
