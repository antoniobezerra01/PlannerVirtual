Public Interface ITarefaDAO

    Sub inserir(ByVal tarefa As Tarefa)
    Sub deletar(ByVal descricao As String)
    Function listar() As List(Of Tarefa)
    Function consultar(ByVal descricao As String) As Tarefa

    Function getTarefasByEstado(tipoLembrete As EstadoAtividade) As List(Of Tarefa)
    Function getAllTarefas() As List(Of Tarefa)

End Interface
