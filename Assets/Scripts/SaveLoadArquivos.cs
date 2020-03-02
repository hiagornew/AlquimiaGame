using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
public class SaveLoadArquivos : MonoBehaviour
{
    //Variáveis do quadrado
    [SerializeField] private ItemConfig quadrado;
    private ItemDate quadradoDados;

    //Variáveis do arquivo
    FileStream file = null;
    BinaryFormatter bf = new BinaryFormatter();

    
    private void Start()
    {
        //quadrado.valorVenda = 500;
        //Save();
        Load();
    }

    public void Save()
    {
        try
        {
            //Pega os dados que serão salvos
            quadradoDados = quadrado.GetDados();
            //Gera o arquivo onde vamos escrever os dados no caminho especificado
            file = File.Create(Application.persistentDataPath + "/Save.cafe");
            Debug.Log(Application.persistentDataPath);
            //Serializa os dados em formato binário e escreve no arquivo
            bf.Serialize(file, quadradoDados);
        }
        catch (Exception e)
        {
            //Imprime mensagem de erro no console
            Debug.Log(e.Message);
        }
        finally
        {
            //Fecha o caminho para o arquivo se ele não estiver vazio. Não fazer isso pode causar vazamento de memória (Memory Leak)
            if (file != null)
            {
                file.Close();
            }
        }
    }

    public void Load()
    {
        try
        {
            //Abre o arquivo no caminho especificado
            file = File.Open(Application.persistentDataPath + "/Save.cafe", FileMode.Open);
            //Desserializa os dados no arquivo
            quadradoDados = (ItemDate)bf.Deserialize(file);
            //Muda os dados do quadrado de acordo com os dados salvos
            quadrado.SetDados(quadradoDados);
        }
        catch (Exception e)
        {
            //Imprime mensagem de erro no console
            Debug.Log(e.Message);
        }
        finally
        {
            //Fecha o caminho para o arquivo se ele não estiver vazio. Não fazer isso pode causar vazamento de memória (Memory Leak)
            if (file != null)
            {
                file.Close();
            }
        }
    }
}